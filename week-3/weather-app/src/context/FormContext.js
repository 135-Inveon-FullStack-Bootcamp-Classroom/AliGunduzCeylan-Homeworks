import { createContext, useState, useContext } from "react";

const FormContext = createContext();

export const FormProvider = ({ children }) => {
    const [form, setForm] = useState({
        "id": 34,
        "city_name": "İSTANBUL",
        "lat": 41.00527,
        "lon": 28.97696,
        "northeast_lat": 41.320786,
        "northeast_lon": 29.456456,
        "southwest_lat": 40.80275,
        "southwest_lon": 27.971307
    });

    const values = { form, setForm };
    console.log(form)
    return <FormContext.Provider value={values}>{children}</FormContext.Provider>

}

export const useForm = () => useContext(FormContext);