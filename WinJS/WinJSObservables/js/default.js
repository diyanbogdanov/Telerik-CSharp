// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        var firstComputerObservable = Data.getComputer("Dell Studio 1535", 2000, "/images/studio-1535.png", "Core i5", 2.0);

        var secondComputer = {
            name: "HP 650",
            imageUrl: "/images/hp-650.jpg",
            price: 1500,
            processor: {
                modelName: "Intel 1000M",
                frequencyGHz: 1.8
            }
        }

        var secondComputerObservable = WinJS.Binding.as(secondComputer);

        var firstComputerElement = document.getElementById("bound-to-observable-class-instance");
        var secondComputerElement = document.getElementById("bound-to-observable-object");

        WinJS.Binding.processAll(firstComputerElement, firstComputerObservable);
        WinJS.Binding.processAll(secondComputerElement, secondComputerObservable);

        setInterval(function () {
            firstComputerObservable.price -= 10;
        }, 1000);

        setInterval(function () {
            secondComputerObservable.price -= 10;
        }, 1000);
    };

    app.start();
})();
