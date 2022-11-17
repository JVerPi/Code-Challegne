// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#btnSubmit").click(function () {

    var cityname = $("#txtCity").val();
    if (cityname.length > 0) {
        $.ajax({
            url: "http://localhost:52189/Home/WeatherDetail?City=" + cityname,
            type: "POST",  
            success: function (rsltval) {
                var data = JSON.parse(rsltval);
                console.log(data);
                $("#lblCity").html(data.City);
                $("#lblCountry").text(data.Country);
                $("#lblLat").text(data.Lat);
                $("#lblLon").text(data.Lon);
                $("#lblDescription").text(data.Description);
                $("#lblTemperature").text(data.TempFeelsLike);
                $("#lblHumidity").text(data.Humidity);
                $("#lblpreassure").text(data.Humidity);
                $("#lblTempMax").text(data.TempMax);
                $("#lblTempMin").text(data.TempMin);
                $("#lblairspeed").text(data.airspeed);
                $("#lblairdirection").text(data.airdirection);
                $("#imgWeatherIconUrl").attr("src", "http://openweathermap.org/img/w/" + data.WeatherIcon + ".png");
                //data - response from server
            },
            error: function () {

            }
        });
    }
    else {
        alert("City Not Found");
    }
});