

function ValidatRegisterationInputs() {
    if ($("#txtName").val() == "") {
        alert('please fill the required field');
        $("#txtName").focus();
       
        return false;
    }
    if ($("#txtEmail").val() == "") {
        alert('please fill the required field');
        $("#txtEmail").focus();

        return false;
    }
    else if (!(validateEmail())) {
        alert("Please enter correct email ID")
        $("#txtEmail").focus();
               return false;
    }
    
    if ($("#txtPhone").val() == "" || $("#txtPhone").val().length < 10) {
        alert('please fill the required field');
        $("#txtPhone").focus();
        return false;
    }
    if ($("#txtAddress").val() == "") {
        alert('please fill the required field');
        $("#txtAddress").focus();
        return false;
    }
    if ($("#txtWeight").val() == "" || isNaN($("#txtWeight").val())) {
        alert('please fill the required field');
        $("#txtWeight").focus();
        return false;
    }
    if ($("#txtHeight").val() == "" || isNaN($("#txtHeight").val())){
        alert('please fill the required field');
        $("#txtHeight").focus();
        return false;
    }
    if ($("#medicalConditionSelect").val() == "-1") {
        alert('please fill the required field');
        $("#medicalConditionSelect").focus();

        return false;
    }

    else
        return true;
}
function validateEmail() {
    var email = $("#txtEmail").val();
    atpos = email.indexOf("@");
    dotpos = email.lastIndexOf(".");
    if (atpos < 1 || (dotpos - atpos < 2)) {
       
        return false;
    }
    return (true);
} 

function validatDiet() {
    if ($("#txtDName").val() == "") {
        alert('please fill the required field');
        $("#txtDName").focus();

        return false;
    }
    if ($("#txtCarbs").val() == "" || isNaN($("#txtCarbs").val())) {
        alert('please fill the required field');
        $("#txtCarbs").focus();
        return false;
    }
    if ($("#txtProutin").val() == "" || isNaN($("#txtProutin").val())) {
        alert('please fill the required field');
        $("#txtProutin").focus();
        return false;
    }
    if ($("#txtVitamin").val() == "" || isNaN($("#txtVitamin").val())) {
        alert('please fill the required field');
        $("#txtVitamin").focus();
        return false;
    }
    if ($("#txtMinerals").val() == "" || isNaN($("#txtMinerals").val())) {
        alert('please fill the required field');
        $("#txtMinerals").focus();
        return false;
    }
    if ($("#txtFat").val() == "" || isNaN($("#txtFat").val())) {
        alert('please fill the required field');
        $("#txtFat").focus();
        return false;
    }
    if ($("#TADescription").val() == "") {
        alert('please fill the required field');
        $("#TADescription").focus();

        return false;
    }
    else
        return true;
}

function validatMeal() {
    if ($("#txtMName").val() == "") {
        alert('please fill the required field');
        $("#txtMName").focus();

        return false;
    }
    if ($("#txtPrice").val() == "" || isNaN($("#txtPrice").val())) {
        alert('please fill the required field');
        $("#txtPrice").focus();
        return false;
    }
    if ($("#SelectMealType").val() == "-1") {
        alert('please fill the required field');
        $("#SelectMealType").focus();

        return false;
    }
    else
        return true;
}



function validateLogin() {
    if ($("#tb_userName").val() == "") {
        alert('please fill the required field');
        $("#tb_userName").focus();

        return false;
    }
    if ($("#tb_password").val() == "") {
        alert('please fill the required field');
        $("#tb_password").focus();

        return false;
    }
    else
        return true;
}