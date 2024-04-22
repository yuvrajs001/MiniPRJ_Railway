// Function to multiply two numbers
function multiplyNumbers() {
    var num1 = document.getElementById('N1').value;
    var num2 = parseFloat(document.getElementById('N2').value);
    var result = num1 * num2;
    document.getElementById('result').innerText = 'Result: ' + result;
}

// Function to divide two numbers
function divideNumbers() {
    var num1 = parseFloat(document.getElementById('N1').value);
    var num2 = parseFloat(document.getElementById('N2').value);

    if (num2 !== 0) {
        var result = num1 / num2;
        document.getElementById('result').innerText = 'Result: ' + result;
    } else {
        document.getElementById('result').innerText = 'We can not divide by zero';
    }
}

// Function to check if numbers from 0 to 15 are odd or even
function checkOddOrEven() {
    var outputList = document.getElementById('output');

    for (var i = 0; i <= 15; i++) {
        var listItem = document.createElement('li');

        if (i % 2 === 0) {
            listItem.textContent = i + ' is even';
        } else {
            listItem.textContent = i + ' is odd';
        }

        outputList.appendChild(listItem);
    }
}



const button = document.getElementById('button');


const message = document.getElementById('message');

button.addEventListener('click', function () {
   
    message.textContent = 'Button clicked!';
});




// Assign functions to button click events
document.getElementById('b1').onclick = multiplyNumbers;
document.getElementById('b2').onclick = divideNumbers;
document.getElementById('OddEven').onclick = checkOddOrEven;
