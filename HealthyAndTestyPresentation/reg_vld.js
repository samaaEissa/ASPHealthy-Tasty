$("#btn_register").click(function () {
    if ($("#txtName").val() == "")
        alert('please fill the required field');
    else if ($("#txtEmail").val() == "")
        alert('please fill the required field');
    else if ($("#txtPhone").val() == "" || $("#txtPhone").val().length<11)
        alert('please fill the required field');
    else if ($("#txtAddress").val() == "")
        alert('please fill the required field');
    else if ($("#txtWeight").val() == "" || isNaN($("#txtWeight")))
        alert('please fill the required field with a number');
    else if ($("#txtHeight").val() == "" || isNaN($("#txtHeight")))
        alert('please fill the required field with a number');
    else
        return true;
});