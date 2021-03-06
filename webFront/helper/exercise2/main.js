function retrieveAllContracts() {
    var targetUrl = "https://api.jcdecaux.com/vls/v3/contracts?apiKey=" + document.getElementById("apiKey").value;
    var requestType = "GET";

    var caller = new XMLHttpRequest();
    caller.open(requestType, targetUrl, true);
    // The header set below limits the elements we are OK to retrieve from the server.
    caller.setRequestHeader ("Accept", "application/json");
    // onload shall contain the function that will be called when the call is finished.
    caller.onload=contractsRetrieved;

    caller.send();
}

function contractsRetrieved() {
    // Let's parse the response:
    var response = JSON.parse(this.responseText);
    console.log(response);
    for (var i = 0; i < response.length;i++) {
        var li = document.createElement("option");
        li.setAttribute("value", response[i].name);
        let name = document.createTextNode(response[i].name);
        li.appendChild(name);
        document.getElementById("input").appendChild(li);
    }
}