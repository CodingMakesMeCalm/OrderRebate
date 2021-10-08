$(function () {

    $("#getbutton").click(async (e) => {

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
            let salesname = $("#TextBoxFindSales").val();
            $("#status").text("please wait...");
            $("#myModal").modal("toggle");
            let response = await fetch(`/api/OrderDetails/${salesname}`);
            if (response.ok) {
                let data = await response.json();
                alert(data[0].salesname);
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

                document.getElementById('OrderDetailTable').innerHTML = tablecontent;
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

    $("#updatebutton").click(async (e) => {
        try {
            stu = new Object();
            stu.title = $("#TextBoxTitle").val();
            stu.firstname = $("#TextBoxFirstname").val();
            stu.lastname = $("#TextBoxLastname").val();
            stu.phoneno = $("#TextBoxPhone").val();
            stu.email = $("#TextBoxEmail").val();
            stu.divisionName = "";
            stu.picture64 = "";

            stu.id = parseInt(sessionStorage.getItem("id"));
            stu.divisionId = parseInt(sessionStorage.getItem("divisionId"));
            stu.timer = sessionStorage.getItem("timer");

            let response = await fetch("api/student", {
                method: "PUT",
                headers: { "Content-Type": "application/json; charset=utf-8" },
                body: JSON.stringify(stu)
            });

            if (response.ok) {
                let payload = await response.json();
                $("#status").text(payload.msg);
            } else if (response.status !== 404) {
                let problemJson = await response.json();
                errorRtn(problemJson, response.status);
            } else {
                $("#status").text("no such path on server");
            }
        } catch (error) {
            $("status").text(error.message);
            console.table(error);
        }
    });
});


conserrorRtn = (problemJson, status) => {
    if (status > 499) {
        $("#status").text("Problem server side, see debug console");
    }
    else {
        let keys = Object.keys(problemon.errors)
        problem = {
            status: status,
            statusText: problemJson.errors[keys[0]][0],
        };
        $("#status").text("Problem client side, see browser console");
        console.log(problem);
    }
}