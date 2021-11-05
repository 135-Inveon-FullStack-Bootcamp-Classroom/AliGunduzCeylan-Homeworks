import KeyButton from "../key-button/KeyButton";

const styles = {
  container: {
    width: "100%",
    height: "65%",
    display: "flex",
    flexWrap: "wrap",
  },
};

const KeysSection = () => {
  return (
    <div style={styles.container}>
      <KeyButton label="%" operator />
      <KeyButton label="CE" operator />
      <KeyButton label="C" operator />
      <KeyButton label="<-" operator />

      <KeyButton label="1/x" operator />
      <KeyButton label="x^2" operator />
      <KeyButton label="kök(x)" operator />
      <KeyButton label="/" operator />

      <KeyButton label="7" isNumber isDark />
      <KeyButton label="8" isNumber isDark />
      <KeyButton label="9" isNumber isDark />
      <KeyButton label="x" operator />

      <KeyButton label="4" isNumber isDark />
      <KeyButton label="5" isNumber isDark />
      <KeyButton label="6" isNumber isDark />
      <KeyButton label="-" operator />

      <KeyButton label="1" isNumber isDark />
      <KeyButton label="2" isNumber isDark />
      <KeyButton label="3" isNumber isDark />
      <KeyButton label="+" operator />

      <KeyButton label="+/-" operator isDark />
      <KeyButton label="0" isNumber isDark />
      <KeyButton label="," operator isDark />
      <KeyButton label="=" operator isBlue />
    </div>
  );
};

export default KeysSection;
