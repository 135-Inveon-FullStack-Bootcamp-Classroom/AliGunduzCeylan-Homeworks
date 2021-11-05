import React, { useState, createContext } from "react";

export const CalcContext = createContext();

export const CalcProvider = ({ children }) => {
  const [mainText, setMainText] = useState("0");
  const [resetMainTextNextTime, setResetMainTextNextTime] = useState(true);

  const [lastResult, setLastResult] = useState();
  const [currentOperation, setCurrentOperation] = useState();

  const handleKeyClick = (isNumber, label, operator) => {
    if (isNumber) {
      if (resetMainTextNextTime) {
        setMainText(label);
        setResetMainTextNextTime(false);
      } else {
        setMainText((mainText) => {
          return mainText + label;
        });
      }
    }

    if (operator) {
      setCurrentOperation(label);
      setResetMainTextNextTime(true);
      switch (label) {
        case "+":
          if (!lastResult) {
            setLastResult(Number(mainText));
          } else {
            setLastResult(Number(mainText) + lastResult);
            setMainText(Number(mainText) + lastResult);
          }

          break;
        case "-":
          if (!lastResult) {
            setLastResult(Number(mainText));
          } else {
            setLastResult(lastResult - Number(mainText));
            setMainText(lastResult - Number(mainText));
          }
          break;
        case "x":
          if (!lastResult) {
            setLastResult(Number(mainText));
          } else {
            setLastResult(lastResult * Number(mainText));
            setMainText(lastResult * Number(mainText));
          }
          break;
        case "/":
          if (!lastResult) {
            setLastResult(Number(mainText));
          } else {
            setLastResult(lastResult / Number(mainText));
            setMainText(lastResult / Number(mainText));
          }
          break;
        case "=":
          if (!lastResult) {
            setLastResult(Number(mainText));
          } else {
            setLastResult(lastResult + Number(mainText));
          }
          break;
        case "C":
          setMainText("0");
          setLastResult("");
          break;
        case "CE":
          setMainText("0");
          break;
        case "1/x":
          if (!lastResult) {
            setLastResult(1 / Number(mainText));
            setMainText(1 / Number(mainText));
          } else {
            setLastResult(1 / Number(mainText));
            setMainText(1 / Number(mainText));
          }
          break;
        case "kök(x)":
          if (!lastResult) {
            setLastResult(Math.pow(Number(mainText), 0.5));
            setMainText(Math.pow(Number(mainText), 0.5));
          } else {
            setLastResult(Math.pow(Number(mainText), 0.5));
            setMainText(Math.pow(Number(mainText), 0.5));
          }
          break;
        case "x^2":
          if (!lastResult) {
            setLastResult(Math.pow(Number(mainText), 2));
            setMainText(Math.pow(Number(mainText), 2));
          } else {
            setLastResult(Math.pow(Number(mainText), 2));
            setMainText(Math.pow(Number(mainText), 2));
          }
          break;
        case "+/-":
          if (!lastResult) {
            setLastResult(-Number(mainText));
            setMainText(-Number(mainText));
          } else {
            setLastResult(-Number(mainText));
            setMainText(-Number(mainText));
          }
          break;
        case ".":
          if (!lastResult) {
            setLastResult(Number(`0.${mainText}`));
            setMainText(Number(`0.${mainText}`));
          } else {
            setLastResult(Number(`${mainText}.`));
            setMainText(Number(`${mainText}.`));
          }
          break;
        default:
          break;
      }
    }
  };

  return (
    <CalcContext.Provider
      value={{
        mainText,
        setMainText,
        handleKeyClick,
        resetMainTextNextTime,
        setResetMainTextNextTime,
        lastResult,
        currentOperation,
      }}
    >
      {children}
    </CalcContext.Provider>
  );
};
