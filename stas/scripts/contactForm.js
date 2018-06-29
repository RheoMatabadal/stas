var contactForm = contactForm || {
    init: function () {
        this.listeners();
    },
    listeners: function () {
        $(document).on('click', '.contact-submit', function (e) {
           
            e.preventDefault();
            $('#contact-form').submit();
        })
    },
    showResult: function () {
        $("#exampleModalCenter").hide();
        $("#form-result").show();
    }
}
contactForm.init();