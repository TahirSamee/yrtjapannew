$(document).ready(function () {
    // Attach click event listener to dropdown items
    $('#currencyDropdown a').click(function (e) {
        e.preventDefault(); // Prevent the default anchor behavior

        let selectedCurrency = $(this).data('currency'); // Get the data-currency attribute
        let currencyIcon = $('#currencyIcon');

        // Update the class based on the selected currency
        if (selectedCurrency === 'us') {
            currencyIcon.attr('class', 'fi fi-us');
        } else if (selectedCurrency === 'jp') {
            currencyIcon.attr('class', 'fi fi-jp');
        }
    });

    $('#countryDropdown a').click(function (e) {
        e.preventDefault(); // Prevent the default link behavior

        var selectedCountry = $(this).data('country'); // Get the data-country attribute
        var countryIcon = $('#countryDropdown').prev().find('i'); // Find the <i> element for the icon

        // Update the class based on the selected country
        countryIcon.attr('class', 'fi fi-' + selectedCountry);
    });

    $('.btn-close').click(function () {
        $(this).closest('.alert').hide();
    });
});

function togglePasswordVisibility() {
    const passwordField = document.getElementById("password");
    const toggleIcon = document.getElementById("toggleEye");

    if (passwordField.type === "password") {
        passwordField.type = "text";
        toggleIcon.classList.remove("fa-eye-slash");
        toggleIcon.classList.add("fa-eye");
    } else {
        passwordField.type = "password";
        toggleIcon.classList.remove("fa-eye");
        toggleIcon.classList.add("fa-eye-slash");
    }
}
function toggleConfirmPasswordVisibility() {
    const passwordField = document.getElementById("confirmPassword");
    const toggleIcon = document.getElementById("toggleEyeConfirm");

    if (passwordField.type === "password") {
        passwordField.type = "text";
        toggleIcon.classList.remove("fa-eye-slash");
        toggleIcon.classList.add("fa-eye");
    } else {
        passwordField.type = "password";
        toggleIcon.classList.remove("fa-eye");
        toggleIcon.classList.add("fa-eye-slash");
    }
}
