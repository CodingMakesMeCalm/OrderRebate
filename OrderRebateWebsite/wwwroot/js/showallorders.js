$(document).ready(async function () {

    let tablecontent = '';
    tablecontent += '<table border=1><tbody>';
    tablecontent += '<tr>';
    tablecontent += '<td>' + 'Sales Name' + '</td>';
    tablecontent += '<td>' + 'Customer Name:' + '</td>';
    tablecontent += '<td>' + 'Product' + '</td>';
    tablecontent += '<td>' + 'Factory' + '</td>';
    tablecontent += '<td>' + 'Quantity' + '</td>';
    tablecontent += '<td>' + 'Unit Price' + '</td>';
    tablecontent += '<td>' + 'Discount' + '</td>';
    tablecontent += '<td>' + 'Totalprice' + '</td>';
    tablecontent += '</tr>';

    try {
        let response = await fetch(`/api/AllOrders`);
        if (response.ok) {
            let data = await response.json();
            let jsonLength = Object.keys(data).length;
            for (let i = 0; i < jsonLength; i++) {
                tablecontent += '<tr>';
                tablecontent += '<td>' + data[i].salesname + '</td>';
                tablecontent += '<td>' + data[i].customername + '</td>';
                tablecontent += '<td>' + data[i].productname + '</td>';
                tablecontent += '<td>' + data[i].factory + '</td>';
                tablecontent += '<td>' + data[i].quantity + '</td>';
                tablecontent += '<td>' + data[i].unitprice + '</td>';
                tablecontent += '<td>' + data[i].discount + '</td>';
                tablecontent += '<td>' + data[i].totalprice + '</td>';
                tablecontent += '</tr>';
            }
            tablecontent += '</tbody></table>';
            document.getElementById('AllOrders').innerHTML = tablecontent;
        }
        else if (response.status !== 404) {
            let problemJson = await response.json();
            errorRtn(problemJson, response.status);
        } else {
            $("#status").text("no such path no server");
        }
    } catch (error) {
        $("#status").text(error.message);
    }

});