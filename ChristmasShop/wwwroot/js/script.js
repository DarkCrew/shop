setTimeout(function () {
    const SLIDER_ELEMENTS = document.querySelectorAll('.slider-element');
    const SLIDER_DESCRIPTIONS = document.querySelectorAll('.slider-description-container');


    for (let i = 0; i < SLIDER_ELEMENTS.length; i++) {
        SLIDER_ELEMENTS[i].addEventListener('mouseenter', function () {
            SLIDER_DESCRIPTIONS[i].classList.add('active');
        });
        SLIDER_ELEMENTS[i].addEventListener('mouseleave', function () {
            SLIDER_DESCRIPTIONS[i].classList.remove('active');
        })
    }
}, 200);

const SEARCH_NAMES = document.querySelectorAll('.search-names-item');
const SEARCH_INPUT = document.querySelector('.search-form-input');
const SEARCH_BUTTON = document.querySelector('.button.search-form-button');

SEARCH_NAMES.forEach(elem => {
    elem.addEventListener('click', function () {
        SEARCH_INPUT.value = elem.innerText;
        SEARCH_BUTTON.click();
    });
});