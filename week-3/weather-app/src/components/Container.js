import React from 'react'
import Weather from './Weather';
import Header from './Header';
import { useWeather } from "../context/WeatherContext";


function Container() {
    const { weather, setWeather } = useWeather();
    return (
        <div className="container">
            <div className="mt-5">
                <div className="row">
                    <div className="col-sm-2">
                        <Header></Header>
                    </div>
                    <div className="col-sm-10">
                        {
                            weather && <Weather></Weather>
                        }
                    </div>
                </div>



            </div>
        </div>
    )
}

export default Container;
