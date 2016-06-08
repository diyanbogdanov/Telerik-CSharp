// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;

    app.onactivated = function (args) {
        WinJS.Binding.processAll();
        
        var secondComputer = {
            name: "HP 650",
            imageUrl: "/images/hp-650.jpg",
            processor: {
                modelName: "Intel 1000M",
                frequencyGHz: 1.8
            }
        }

        var secondComputerElement = document.getElementById("bound-to-object");
        WinJS.Binding.processAll(secondComputerElement, secondComputer);
    };

    app.start();
})();
