/*var http = require('http');

var port = 1234;

http.createServer(function(req, res) {

    res.writeHead(200, {
        'Content-Type': 'text/html',
		'Set-Cookie': '__gfp_64b=YZUQtNt.y1v4nI4qyWl.445FaJ_1gxrClT30uHNm_F3.b7; PHPSESSID=aurgiv6huueol9cm7l2icsjog3; pcwLastView=1418570503; __utmt=1; _auid=7473528b43529a66d95f5406bb9e31a1; _c=y; __utma=34031392.1056547126.1404318513.1418472763.1418570511.91; __utmb=34031392.6.10.1418570511; __utmc=34031392; __utmz=34031392.1418305720.86.19.utmcsr=nm20.abv.bg|utmccn=(referral)|utmcmd=referral|utmcct=/mail/696C0AC755E93528B6585ED6E4CCB2AB.cache.html'
    });

    http.get('http://pcworld.bg/download_pdf.php?r=open_pcw_506', function(academyResponse) {

        var body = '';
        academyResponse.on('data', function(data) {
            body += data;
        })

        academyResponse.on('end', function() {
            res.write(body, 'utf8');
            res.end();
        })
    })

}).listen(port);

console.log('Server running on port ' + port);*/

var http = require('http');

var options = {
	hostname: 'www.pcworld.bg',
	cookie : '__gfp_64b=YZUQtNt.y1v4nI4qyWl.445FaJ_1gxrClT30uHNm_F3.b7; PHPSESSID=jmd0ujquk0i6ul26mrcse8q9j4; pcwLastView=1418307775; __utmt=1; _auid=7473528b43529a66d95f5406bb9e31a1; _c=y; __utma=34031392.1056547126.1404318513.1418307800.1418310557.88; __utmb=34031392.11.10.1418310557; __utmc=34031392; __utmz=34031392.1418305720.86.19.utmcsr=nm20.abv.bg|utmccn=(referral)|utmcmd=referral|utmcct=/mail/696C0AC755E93528B6585ED6E4CCB2AB.cache.html; molang=%u0438%u0437%u043A%u043B%u044E%u0447%u0435%u043D%u0430',
	port : 80,
	method : 'GET'
};

var req = http.request(options, function(res) {
  console.log('STATUS: ' + res.statusCode);
  console.log('HEADERS: ' + JSON.stringify(res.headers));
  res.setEncoding('utf8');
  res.on('data', function (chunk) {
    console.log('BODY: ' + chunk);
  });
});

req.on('error', function(e) {
  console.log('problem with request: ' + e.message);
});

req.end();
