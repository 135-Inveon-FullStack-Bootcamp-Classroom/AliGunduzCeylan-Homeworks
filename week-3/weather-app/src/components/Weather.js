import React from "react";
import { useWeather } from "../context/WeatherContext";

function Weather() {
  const { weather, setWeather } = useWeather();

  const weatherSvg = {
    Clear: <i style={{ color: "#fcc203" }} className="fas fa-sun"></i>,
    Clouds: <i style={{ color: "#76b5c5" }} className="fas fa-cloud"></i>,
    Rain: (
      <i
        style={{ color: "#949494" }}
        className="fas fa-cloud-showers-heavy"
      ></i>
    ),
    Snow: <i style={{ color: "#d9d9d9" }} className="fas fa-snowflake"></i>,
    wind_speed: <i style={{ color: "#949494" }} className="fas fa-wind"></i>,
    temp: (
      <i style={{ color: "#949494" }} className="fas fa-thermometer-half"></i>
    ),
  };

  const card = {
    description: "",
    main: "",
    temp: "",
    min: "",
    max: "",
    wind_speed: "",
    day: "",
  };

  const getDate = (index) => {
    console.log(index);
    var d = new Date();
    var weekday = new Array(7);
    weekday[0] = "Sunday";
    weekday[1] = "Monday";
    weekday[2] = "Tuesday";
    weekday[3] = "Wednesday";
    weekday[4] = "Thursday";
    weekday[5] = "Friday";
    weekday[6] = "Saturday";

    return weekday[(d.getDay() + index) % 7];
  };

  return (
    <div>
      <div className="row">
        {weather.map((item, index) => {
          card.description = item["weather"][0]["description"];
          card.main = item["weather"][0]["main"];
          card.temp = item["temp"]["day"];
          card.min = item["temp"]["min"];
          card.max = item["temp"]["max"];
          card.date = item["dt"];
          card.wind_speed = item["wind_speed"];

          return (
            <div key={index} className="col-sm-4 col-md-3 col-lg-2 rounded-1">
              <div className="card border border-dark mb-3">
                <div className="card-header bg-transparent border-0">
                  {getDate(index)}
                </div>
                <div className="card-body ">
                  <h5 className="card-title">{card.main}</h5>
                  <div className="card-text" style={{ fontSize: 70 }}>
                    {weatherSvg[card.main]}
                  </div>
                  <span>
                    {weatherSvg.wind_speed} {card.wind_speed} <span>km/h</span>
                  </span>
                  <div>{card.description}</div>
                </div>
                <div className="card-footer bg-transparent border-0">
                  <div>
                    <span className="me-3">Min</span>
                    <span className="ms-3">Max</span>
                  </div>
                  <span className="me-1">{weatherSvg.temp}</span>
                  <span className="me-3">{Math.round(card.min)}</span>

                  <span className="ms-2 me-1">{weatherSvg.temp}</span>
                  <span>{Math.round(card.max)}</span>
                </div>
              </div>
            </div>
          );
        })}
      </div>
    </div>
  );
}

export default Weather;
