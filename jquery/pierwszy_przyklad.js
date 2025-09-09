$(function () {
    // Funkcja ustawia styl dla strony: kolor tła, odstępy liter w nagłówku, styl linków oraz zmienia adres href na Wikipedię
    $('#page').css('background-color', '#00FFFF');
    $('h2').css('letter-spacing', '5px');
    $('.link').css({
        'color': 'white',
        'text-decoration': 'none',
    });
    $('[href="#"]').attr('href', 'https://pl.wikipedia.org/wiki/J%C4%99zyk_programowania');
});

$(function () {
    // Funkcja ustawia styl dla nieparzystych linków 
    $('a').odd().css({
        'color': 'blue',
        'text-decoration': 'none',
        'background-color': 'black',
    })
});

$(function () {
    // Funkcja ustawia styl dla wszystkich linków oprócz tego z id "pierwszy"
    $('a').not('#pierwszy').css({

        'text-decoration': 'underline',
        'background-color': 'black',
    })
});

$(function () {
    const $lista_ul = $('ul').html();
    console.log($lista_ul);
    const $lista_li = $('li').html();
    console.log($lista_li);
});

$(function () {
    let $lista_ul = $('ul').text();
    console.log($lista_ul);
    let $lista_li = $('li').text();
    console.log($lista_li + "\n");
});



$(function () {
    let $lista_ul = $('ul').html();
    $('ol').append($lista_ul);

    $lista_ul = $('ul').text();
    $('p').append($lista_ul);
});

$(function () {
    let $zmiana = $('li').eq(2).html();
    $('li').eq(2).remove();
    $('ul').prepend('<li>' + $zmiana + '</li>');
});


$(function () {
    $('h2').before('<img src="best5.png">');
    $('img').after('<hr><br>');
});