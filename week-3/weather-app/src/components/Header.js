import { useForm } from '../context/FormContext.js';
import cities from '../cities.json';


function Header() {
    const { form, setForm } = useForm();

    const handleChange = (e) => {
        setForm(e);
    }

    return (
        <div className="mb-3">
            <select name="city" id="" onChange={(e) => handleChange(JSON.parse(e.target.value))}>
                {
                    cities.cities.map(city => {
                        return <option key={city.id} selected={city.id == 34} value={JSON.stringify(city)}>
                            {city.city_name}
                        </option>
                    })
                }
            </select>
        </div>
    )
}

export default Header
