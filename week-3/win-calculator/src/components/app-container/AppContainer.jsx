import styles from "./AppContainer.module.css";
const AppContainer = ({ children }) => {
  console.log({ children });
  return (
    <div style={styles.appContainer}>
      <div style={styles.calculatorContainer}>{children}</div>
    </div>
  );
};

export default AppContainer;
