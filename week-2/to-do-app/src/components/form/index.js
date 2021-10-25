import { useState, useEffect } from 'react'

function Form({ tasks, setTasks }) {
    const initialFormValues = { task: "", isCompleted: false };
    const [form, setForm] = useState(initialFormValues);

    useEffect(() => {
        setForm(initialFormValues);
    }, [tasks])

    const onChangeInput = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });
    }

    const onSubmit = (e) => {
        e.preventDefault();

        if (form.task === "" || form.isCompleted === "") {
            return false;
        }

        //console.log(form);
        setTasks([...tasks, form])
    }



    return (
        <header className="header">
            <h1>todos</h1>
            <form onSubmit={onSubmit}>
                <input
                    name="task"
                    className="new-todo"
                    placeholder="What needs to be done?"
                    autoFocus
                    value={form.task}
                    onChange={onChangeInput}
                />
            </form>
        </header>
    )
}

export default Form
