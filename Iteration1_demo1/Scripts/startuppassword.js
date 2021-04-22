var password = "";
password = prompt('Please entering the password:', '');
if (password != 'code') {
    alert("You are wrong, exiting");
    window.opener = null;
    window.open("about:blank", "_self").close();
}
