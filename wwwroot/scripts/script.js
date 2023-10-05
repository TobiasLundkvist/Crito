const validateName = (event) => {

    if (event.target.value.length >= 2) {
        document.getElementById('errorName').innerHTML = ""
    }
    else {
        document.getElementById('errorName').innerHTML = "Your Name must contain atleast 2 characters"
    }
}

const validateEmail = (event) => {
    const regExEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/

    if (regExEmail.test(event.target.value)) {
        document.getElementById('errorEmail').innerHTML = ""
    }
    else {
        document.getElementById('errorEmail').innerHTML = "Invalid E-mailaddress, eg. name@domain.com"
    }  
}

const validateMessage = (event) => {

    if (event.target.value.length >= 5) {
        document.getElementById('errorMessage').innerHTML = ""
    }
    else {
        document.getElementById('errorMessage').innerHTML = "Your message must contain atleast 5 characters"
    }
}

const validateSubscriber = (event) => {
    const regExEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/

    if (regExEmail.test(event.target.value)) {
        document.getElementById('errorSubscriber').innerHTML = ""
    }
    else {
        document.getElementById('errorSubscriber').innerHTML = "Invalid E-mailaddress, eg. name@domain.com"
    }
}

