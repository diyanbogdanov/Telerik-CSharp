// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        var firstComputerObservable = Data.getComputer("Dell Studio 1535", 2000, "/images/studio-1535.png", "Core i5", 2.0);
        var secondComputerObservable = Data.getComputer("HP 650", 1500, "/images/hp-650.jpg", "Intel 1000M", 1.8)

        WinJS.UI.processAll().then(function () {
            
            var computerTemplate = new WinJS.Binding.Template(null, {
                href: "/templates/computer-template.html"
            });

            computerTemplate.render(firstComputerObservable, document.body).then(function () {;
                computerTemplate.render(secondComputerObservable, document.body);
            });

            setInterval(function () {
                firstComputerObservable.price -= 10;
            }, 1000);

            setInterval(function () {
                secondComputerObservable.price -= 10;
            }, 1000);
        });
    };

    app.start();
})();
