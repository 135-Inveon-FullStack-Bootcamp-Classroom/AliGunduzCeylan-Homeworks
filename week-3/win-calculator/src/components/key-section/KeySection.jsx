import KeyButton from "./KeyButton";
import styles from "./KeySection.module.css";

const KeysSection = () => {
  return (
    <div style={styles.container}>
      <KeyButton label="%" />
      <KeyButton label="CE" />
      <KeyButton label="C" />
      <KeyButton label="<-" />

      <KeyButton label="1/x" />
      <KeyButton label="x^2" />
      <KeyButton label="kök(x)" />
      <KeyButton label="/" operator />

      <KeyButton label="7" isNumber />
      <KeyButton label="8" isNumber />
      <KeyButton label="9" isNumber />
      <KeyButton label="x" operator />

      <KeyButton label="4" isNumber />
      <KeyButton label="5" isNumber />
      <KeyButton label="6" isNumber />
      <KeyButton label="-" operator />

      <KeyButton label="1" isNumber />
      <KeyButton label="2" isNumber />
      <KeyButton label="3" isNumber />
      <KeyButton label="+" operator />

      <KeyButton label="+/-" isNumber />
      <KeyButton label="0" isNumber />
      <KeyButton label="," isNumber />
      <KeyButton label="=" isBlue />
    </div>
  );
};

export default KeysSection;
