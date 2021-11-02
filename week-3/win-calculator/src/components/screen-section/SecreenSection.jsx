import { useContext } from "react";
import { CalcContext } from "../CalcContext";
import styles from "./ScreenSection.module.css";

const ScreenSection = () => {
  const { mainText, lastResult, currentOperation } = useContext(CalcContext);

  const renderCaption = () => {
    if (lastResult && currentOperation)
      return (
        <span style={styles.caption}>
          {lastResult} {currentOperation}
        </span>
      );
  };

  return (
    <div style={styles.screenSection}>
      {renderCaption()}
      <span style={styles.mainText}>{mainText}</span>
    </div>
  );
};

export default ScreenSection;
