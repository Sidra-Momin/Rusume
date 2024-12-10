$(document).ready(function() {
  // Smooth scrolling for anchor links
  $('a').on('click', function(event) {
    if (this.hash !== "") {
      event.preventDefault();
      var hash = this.hash;
      $('html, body').animate({
        scrollTop: $(hash).offset().top
      }, 800);
    }
  });

  // Contact form validation
  $('#contactForm').on('submit', function(event) {
    event.preventDefault();

    var name = $('#name').val();
    var email = $('#email').val();
    var subject = $('#subject').val();
    var message = $('#message').val();

    if (name && email && subject && message) {
      $('#formMessage').html('<p>Thank you for your message!</p>');
    } else {
      $('#formMessage').html('<p>Please fill out all fields.</p>');
    }
  });
});
