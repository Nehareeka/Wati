var url = "https://localhost:7002";

function add() {
    var a = (Number)(document.getElementById("num1").value);
    var b = (Number)(document.getElementById("num2").value);
    var sum = (Number)(a + b);
    document.getElementById("result").innerText = sum;
}