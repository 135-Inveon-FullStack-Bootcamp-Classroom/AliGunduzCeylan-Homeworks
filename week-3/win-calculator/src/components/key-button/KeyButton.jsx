import { useState, useContext } from "react";
import { CalcContext } from "../CalcContext";
import styles from "./KeyButton.module.css";

const getHoveredStyle = (isBlue) => {
  let hoveredStyle = { cursor: "pointer", backgroundColor: "#999" };
  if (isBlue) hoveredStyle = { ...hoveredStyle, backgroundColor: "#24567a" };

  return hoveredStyle;
};

const getHoveredKeyTextStyle = (hovered) => {
  if (hovered) return { color: "black" };
};

const KeyButton = ({ label, isBlue, isNumber, operator }) => {
  const { handleKeyClick } = useContext(CalcContext);

  const [hovered, setHovered] = useState(false);

  const isBlueStyle = isBlue ? { backgroundColor: "#134569" } : {};
  const isNumberStyle = isNumber ? { backgroundColor: "#070707" } : {};
  const isHoveredStyle = hovered ? getHoveredStyle(isBlue) : {};

  return (
    <div
      style={{
        ...styles.keyContainer,
        ...isBlueStyle,
        ...isNumberStyle,
        ...isHoveredStyle,
      }}
      onMouseEnter={() => setHovered(true)}
      onMouseLeave={() => setHovered(false)}
      onClick={() => handleKeyClick(isNumber, label, operator)}
    >
      <span
        style={{
          ...styles.keyText,
          ...getHoveredKeyTextStyle(hovered),
        }}
      >
        {label}
      </span>
    </div>
  );
};

export default KeyButton;
