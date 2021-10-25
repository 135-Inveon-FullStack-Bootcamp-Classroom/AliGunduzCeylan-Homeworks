import { useState } from 'react'

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
        <div>

        </div>
    )
}

export default Todo
