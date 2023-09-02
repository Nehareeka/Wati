var url = "https://localhost:7002/add";

function add() {
    var a = (Number)(document.getElementById("num1").value);
    var b = (Number)(document.getElementById("num2").value);

    computeSum(a, b);
}

function computeSum(a, b) {
    fetch(url, {
        method: "POST",
        body: JSON.stringify({
            num1: a,
            num2: b
        }),
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    })
        .then((response) => response.json())
        .then((json) => {
            var sum = json;
            document.getElementById("sum").innerText  = sum;
        });
}