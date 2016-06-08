(function () {
    var computer = {
        name: "Dell Studio 1535",
        imageUrl: "/images/studio-1535.png",
        processor: {
            modelName: "Core i5",
            frequencyGHz: 2
        }
    }

    WinJS.Namespace.define("Data", {
        computer: computer
    });
})();