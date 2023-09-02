function add() {
    var a = (Number)(document.getElementById("num1").value);
    var b = (Number)(document.getElementById("num2").value);
    var url = "https://localhost:7002/add";

    computeSum(a, b, url);
}

function computeSum(a, b, url) {
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
        })
        .catch(() => computeSum(a, b, "https://localhost:61874/add"));
}