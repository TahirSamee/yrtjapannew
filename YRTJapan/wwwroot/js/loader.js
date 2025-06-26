function showLoader(message = "Loading, please wait...") {
    document.getElementById('customLoader').style.display = 'flex';
    document.querySelector('.loader-message').textContent = message;
}
function hideLoader() {
    document.getElementById('customLoader').style.display = 'none';
}
