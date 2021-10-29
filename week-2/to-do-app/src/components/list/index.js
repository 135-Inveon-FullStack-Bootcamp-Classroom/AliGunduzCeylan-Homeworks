import { useState, useEffect } from 'react'

function List({ tasks, setTasks }) {

    const [copyTask, setCopyTask] = useState(tasks);
    const [filterList, setFilterList] = useState([false, false, false, false]);

    useEffect(() => {
        setCopyTask([...tasks])
    }, [tasks])

    // delete task
    const destroyTask = (e) => {
        const id = e.target.id;
        setTasks(tasks.filter((item, index) => index != id))
    }

    // when tasks checked
    const checked = (e) => {
        const name = e.target.name;
        setTasks(
            tasks.map((item, index, arr) => {
                if (item.task == name) {
                    console.log(item.isCompleted)
                    item.isCompleted = item.isCompleted ? false : true;
                    return item
                }
                else {
                    return item;
                }
            })
        )



    }

    // for filter tasks
    const filter = (e) => {
        const name = e.target.name;

        if (name == "all") {
            setCopyTask([...tasks]);
            setFilterList([true, false, false, false]);
        }
        else if (name == "active") {
            setCopyTask(tasks.filter(item => item.isCompleted == false));
            setFilterList([false, true, false, false]);
        }
        else if (name == "completed") {
            setCopyTask(tasks.filter(item => item.isCompleted == true));
            setFilterList([false, false, true, false]);
        }
        else if (name == "clear") {
            setTasks(tasks.filter(item => !item.isCompleted));
            setFilterList([false, false, false, true]);
        }
    }

    return (
        <div>
            {/* <!-- This section should be hidden by default and shown when there are todos --> */}
            <section className="main">
                <input className="toggle-all" type="checkbox" />
                <label htmlFor="toggle-all">Mark all as complete</label>

                <ul className="todo-list">

                    {copyTask.map((tasks, index) => (
                        <li key={index} className={tasks.isCompleted ? "completed" : "view"} >
                            <div className="view">
                                <input name={tasks.task} style={{ width: "100%" }} className="toggle" type="checkbox" onClick={checked} />
                                <label >{tasks.task}</label>
                                <button id={index} className="destroy" onClick={destroyTask}></button>
                            </div>
                        </li>
                    ))}

                </ul>
            </section>

            {/* <!-- This footer should hidden by default and shown when there are todos --> */}
            <footer className="footer">
                {/* <!-- This should be `0 items left` by default --> */}
                <span className="todo-count">
                    <strong>2</strong>
                    items left
                </span>

                <ul className="filters">
                    <li>
                        <a name="all" onClick={filter} className={filterList[0] ? "selected" : " "} >All</a>
                    </li>
                    <li>
                        <a name="active" onClick={filter} className={filterList[1] ? "selected" : " "}>Active</a>
                    </li>
                    <li>
                        <a name="completed" onClick={filter} className={filterList[2] ? "selected" : " "}>Completed</a>
                    </li>
                </ul>

                {/* <!-- Hidden if no completed items are left ↓ --> */}
                <button name="clear" onClick={filter} className={filterList[3] ? "selected clear-completed" : "clear-completed"}>Clear completed</button>
            </footer>


        </div>
    )
}

export default List;
