// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {

        var lightData = {
            wavelengthNm: 400
        }

        lightData = WinJS.Binding.as(lightData);

        var wavelengthInput = document.getElementById("wavelength-input");
        wavelengthInput.addEventListener("change", function (event) {
            lightData.wavelengthNm = wavelengthInput.value;
        });

        var lightColorElement = document.getElementById("light-color");

        WinJS.Binding.processAll(lightColorElement, lightData);
    };

    app.start();
})();
