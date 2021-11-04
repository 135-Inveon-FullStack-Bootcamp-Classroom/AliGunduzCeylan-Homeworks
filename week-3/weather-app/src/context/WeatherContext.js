import { createContext, useState, useEffect, useContext } from "react";
import { useForm } from '../context/FormContext.js';
import axios from "axios";

const WeatherContext = createContext();
const API_KEY = process.env.REACT_APP_WEATHER_API_KEY;


export const WeatherProvider = ({ children }) => {
    const [weather, setWeather] = useState();
    const { form, setForm } = useForm();

    useEffect(() => {
        axios(
            `https://api.openweathermap.org/data/2.5/onecall?lat=${form.lat}&lon=${form.lon}&exclude=alerts&units=metric&appid=${API_KEY}`
        )
            .then((res) => setWeather(res.data.daily))
            .catch((e) => console.log(e));

        console.log(weather)
    }, [form])

    const values = {
        weather,
        setWeather,
    };

    return <WeatherContext.Provider value={values}>{children}</WeatherContext.Provider>

}

export const useWeather = () => useContext(WeatherContext);




