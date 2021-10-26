import { useState } from 'react'
import Form from './form';
import List from './list';

function Todo() {
    const [tasks, setTasks] = useState([
        {
            task: "Learn JavaScript",
            isCompleted: false
        },
        {
            task: "Learn React",
            isCompleted: false
        },
        {
            task: "Have a life",
            isCompleted: false
        }
    ]);

    return (
        <section className="todoapp">
            <Form tasks={tasks} setTasks={setTasks}></Form>
            <List tasks={tasks} setTasks={setTasks}></List >
        </section>
    )
}

export default Todo
