(function () {

    var wavelengthToCSSColorConverter = WinJS.Binding.converter(function(wavelengthNm){
        if(wavelengthNm < 400) return "black";
        if(wavelengthNm < 450) return "purple";
        if(wavelengthNm < 550) return "blue";
        if(wavelengthNm < 620) return "yellow";
        if(wavelengthNm <= 740) return "red";
        return "black";
    });

    WinJS.Namespace.define("Converters", {
        wavelengthToCSSColor: wavelengthToCSSColorConverter
    });
})()