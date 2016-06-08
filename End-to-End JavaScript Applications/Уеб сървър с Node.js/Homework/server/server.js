/*global require, console, uuid*/
"use strict";
var http = require('http'),
	urll = require('url'),
    util = require('util'),
    formidable = require('formidable'),
    fs = require('fs'),
    uuid = require('node-uuid'),
	path = require('path');

var _PORT = 7777,
    _UPLOAD_DIRECTORY = "../uploads";

function findExtention(str) {
    var indexOfExtention = str.indexOf('.');
    if (indexOfExtention) {
        return str.substring(indexOfExtention);
    } else {
        throw new Error('Invalid file');
    }
}

http.createServer(function(req, res) {
	var url = urll.parse(req.url);
	
	switch (url.pathname){
		case '/uploads':
			upload(req, res);
			break;
		case '/getImage':
			getImage(req, res, url);
			break;
		case '/scripts/file-sender.js':
			showScriptFile(req, res, url.pathname);
			break;
		default:
			display_form(req,res);
			break;
	}
		
}).listen(_PORT);
console.log("The server is up and running @ http://localhost:" + _PORT);

function display_form(req, res) {
	var fp = path.join(__dirname, '../html/index.html'); 
	
	res.writeHead(200, {
            'Content-Type' : 'text/html; charset = utf - 8 '
	});
	
	var readStream = fs.createReadStream(fp);
    readStream.on('data', function(data) {
		res.write(data);
    });
    
    readStream.on('end', function() {
        res.end();        
    });
}

function upload(req, res) {
var uploadedFiles = [],
            form = new formidable.IncomingForm();

        form.uploadDir = _UPLOAD_DIRECTORY;
        form.multiples = true;
        form.keepExtensions = true;

        if (!fs.existsSync(_UPLOAD_DIRECTORY)) {
            fs.mkdirSync(_UPLOAD_DIRECTORY);
        }

        // Rename the file whit GUID
        form.on('fileBegin', function(name, file) {
            var fileName = form.uploadDir + "/" + uuid.v4() + findExtention(file.name);
            uploadedFiles.push(fileName);
            file.path = fileName;
        });

        form.parse(req, function(err, fields, photos) {
            if (err) {
                console.log(err);
            } else {
                res.writeHead(200, {
                    'content-type': 'text/text'
                });
                var fileName;
                for (var x = 0; x < uploadedFiles.length; x++) {
                    fileName = uploadedFiles[x].substring(_UPLOAD_DIRECTORY.length + 1);
                    x === uploadedFiles.length - 1 ? res.write(fileName) : res.write(fileName + '[|]');
                }
                res.end();
            }
        });

        return;
}

function getImage(req, res, url) {

	fs.readFile('../uploads/' + url.query, function(err, image) {
        if (err) {
            console.log("Sorry but the file is no longer existing.");
        }
        res.writeHead(200, {
            'content-type': 'image/png'
        })
        res.end(image, 'binary');
    });
}

function showScriptFile(req, res, url) {
	fs.readFile('..' + url, function(err, data) {
        if (err) {
            console.log(err);
        }
        res.writeHead(200, {
            'Content-type': 'text/javascript'
        });
        res.end(data);
    });
}

