window.addEventListener("load", function () {
    var loader = document.querySelector(".loader");
    loader.classList.add("hidden");
});

// Search start

let $searchBtn = document.querySelector('.searchBtn');

let $xBtn = document.querySelector('.fa-times');

let $discountText = document.querySelector('.discount-text');

let $discountLink = document.querySelector('.discount-link');

let $searchInput = document.querySelector('.search-input');

let $discountHeader = document.getElementById('discount-header');

$searchBtn.addEventListener('click', (e) => {
    e.preventDefault();

    // console.log("Search");
    $discountText.classList.toggle('d-none');
    $discountLink.classList.toggle('d-none');
    $searchInput.classList.add('d-flex');
    $searchInput.classList.remove('d-none');
    $searchBtn.classList.toggle('d-none');
    $xBtn.classList.toggle('d-none');
})

$xBtn.addEventListener('click', (e) => {
    e.preventDefault();

    // console.log("Search");
    $discountText.classList.toggle('d-none');
    $discountLink.classList.toggle('d-none');
    $searchInput.classList.add('d-none');
    $searchInput.classList.remove('d-flex');
    $searchBtn.classList.toggle('d-none');
    $xBtn.classList.toggle('d-none');
})

// Search End

//Filter navbar start

window.addEventListener("resize", (e) => {
    e.preventDefault();
    let $pageWidth = document.body.clientWidth;
    let $filterNavbar = document.querySelector('.filter-navbar');
    let $filters = document.querySelector('.filters');

    if($pageWidth < 992) {
        $filterNavbar.classList.remove('filter-d-none'); 
        $filters.classList.add('filter-d-none'); 
        // console.log("<992");  
    }

    else {
        $filterNavbar.classList.add('filter-d-none'); 
        $filters.classList.remove('filter-d-none'); 

        // console.log(">992")
    }

})


//Filter navbar end