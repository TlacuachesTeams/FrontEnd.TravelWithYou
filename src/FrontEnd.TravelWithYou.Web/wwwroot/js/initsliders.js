document.addEventListener('DOMContentLoaded', function () {

    if ($('#splide').length > 0) {
        //Slide Destinos
        new Splide('#splide', {
            perPage: 3,
            perMove: 1,
            breakpoints: {
                '992': {
                    perPage: 2,
                    gap: '1rem',
                },
                '768': {
                    perPage: 1,
                    gap: '1rem',
                },
                '576': {
                    perPage: 1,
                    gap: '1rem',
                },
            }
        }).mount();
    }
    
    if ($('#splide-2').length > 0) {
        // Slide Ofertas
        new Splide('#splide-2', {
            perPage: 4,
            perMove: 1,
            breakpoints: {
                '1200': {
                    perPage: 3,
                    gap: '1rem',
                },
                '992': {
                    perPage: 2,
                    gap: '1rem',
                },
                '768': {
                    perPage: 2,
                    gap: '1rem',
                },
                '576': {
                    perPage: 1,
                    gap: '1rem',
                },
            }
        }).mount();
    }
    
    if ($('#splide-3').length > 0) {
        //Slide Tours
        new Splide('#splide-3', {
            perPage: 3,
            perMove: 1,
            breakpoints: {
                '992': {
                    perPage: 2,
                    gap: '1rem',
                },
                '768': {
                    perPage: 1,
                    gap: '1rem',
                },
                '576': {
                    perPage: 1,
                    gap: '1rem',
                },
            }
        }).mount();
    }
    

});