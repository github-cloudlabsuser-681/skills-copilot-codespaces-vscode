function getNumbers() {
    const num1 = parseFloat(document.getElementById('num1').value);
    const num2 = parseFloat(document.getElementById('num2').value);
    return { num1, num2 };
}

function add() {
    const { num1, num2 } = getNumbers();
    const result = num1 + num2;
    document.getElementById('result').innerText = `Result: ${result}`;
}

function subtract() {
    const { num1, num2 } = getNumbers();
    const result = num1 - num2;
    document.getElementById('result').innerText = `Result: ${result}`;
}

function multiply() {
    const { num1, num2 } = getNumbers();
    const result = num1 * num2;
    document.getElementById('result').innerText = `Result: ${result}`;
}

function divide() {
    const { num1, num2 } = getNumbers();
    if (num2 === 0) {
        document.getElementById('result').innerText = 'Error: Division by zero';
    } else {
        const result = num1 / num2;
        document.getElementById('result').innerText = `Result: ${result}`;
    }
}