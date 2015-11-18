function OnReady() {
  console.log('Pagina geladen, DOM klaar voor gebruik.');
    $('p').addClass('hidden');
    
    // refreshen van Honden uit Localstorage
    var dog_list = JSON.parse(localStorage.getItem('dogs'));
    if (Array.isArray(dog_list)) {
        for (var i = 0; i < dog_list.length; ++i) {
            var dog = dog_list[i];
            $('#tabelHond').find('tbody:last').append('<tr><td>' + dog.name + '</td><td>' + dog.age + '</td><td>' + dog.regnr + '</td><td>' + dog.reserved + '</td></tr>');
        }
    }
    
    // refreshen van Katten uit Localstorage
    var cat_list = JSON.parse(localStorage.getItem('cats'));
    if (Array.isArray(cat_list)) {
        for (var i = 0; i < cat_list.length; ++i) {
            var cat = cat_list[i];
            $('#tabelKat').find('tbody:last').append('<tr><td>' + cat.name + '</td><td>' + cat.age + '</td><td>' + cat.regnr + '</td><td>' + cat.reserved + '</td></tr>');
        }
    } 
}
$(document).ready(OnReady);


// focus1
function focus1() {
    $('#p1').removeClass('hidden');
    //console.log("focus");
};

// focus2
function focus2() {
    $('#p2').removeClass('hidden');
    //console.log("focus");
};

// blur
function blur() {
    $('p').addClass('hidden');
    //console.log("blur");        
};

// verwijder alle katten
function RemoveCats() {
    localStorage.removeItem('cats'); 
    location.reload();    
};

// verwijder alle honden
function RemoveDogs() {
    localStorage.removeItem('dogs');
    location.reload();   
};

//functies
$(function() {
    
    // aanroepen focus1
    $('#Naam').on('focus', function(){
        focus1();
    });
    
    // aanroepen focus2
    $('#Chipnummer').on('focus', function(){
        focus2();
    });
    
    // aanroepen blur
    $('#Naam').on('blur', function(){
        blur();
    });
    
    // aanroepen blur
    $('#Chipnummer').on('blur', function(){
        blur();
    });
    
    // roept OnSubmit() aan bij het klikken op de submitbutton
    $('#verzenden').on('click', function(){
        OnSubmit();
    });
    
    // roept RemoveDogs() aan bij het klikken op de 'verwijderkat-button'
    $('.resethond').on('click', function(){
        console.log("hond wordt verwijderd");
        RemoveDogs();
    });
    
    // roept RemoveCats() aan bij het klikken op de 'verwijderkat-button'
    $('.resetkat').on('click', function(){
        console.log("kat wordt verwijderd");
        RemoveCats();
    });
});

//Submit button
function OnSubmit(event) {

    var animal = {
  'species':  $('input[name=soort]:checked').val(),
  'name':     $('#Naam').val(),
  'age':      $('#Leeftijd').val(),
  'regnr':    $('#Chipnummer').val(),
  'reserved': $('#Gereserveerd').val()
    };
        
    if(animal.species == "Hond")
        {
        if(animal.name.length > 0)
            {
                if(animal.age >= 0 || animal.age == "")
                    {
                        if(animal.regnr > 0 && animal.regnr < 100000)
                            {
                                if(animal.reserved == "True" || animal.reserved == "False")
                                    {
                                        alert("soort: " + animal.species + '\n' + 
                              "Naam: " + animal.name + '\n' +
                              "Leeftijd: " + animal.age + '\n' + 
                              "Chipnummer: " + animal.regnr + '\n' +
                              "Gereserveerd: " + animal.reserved + '\n' + '\n' + "... is succesvol toegevoegd!");
                        
                        var dog_list = JSON.parse(localStorage.getItem('dogs'));
                        if (!Array.isArray(dog_list)) {
                            dog_list = [];
                        }
                        dog_list.push(animal);
                        localStorage.setItem('dogs', JSON.stringify(dog_list)); 
                                    }
                                else
                                {
                                    alert("Kies: True / False");
                                    event.preventDefault();
                                }
                            }
                        else
                        {
                            alert("Vul een chipnummer tussen de 0 en de 100000 in");
                            event.preventDefault();
                        }
                    }
                    else
                    {
                        alert("Vul de leeftijd in, groter dan 0 of laat het veld leeg");
                        event.preventDefault();
                    }
            }
            else
            {
                alert("Vul een naam in");
                event.preventDefault();
            }
        }  
    else if(animal.species == "Kat")
        {
        if(animal.name.length > 0)
            {
                if(animal.age >= 0 || animal.age == "")
                    {
                        if(animal.regnr > 0 && animal.regnr < 100000)
                            {
                                if(animal.reserved == "True" || animal.reserved == "False")
                                    {
                                        alert("soort: " + animal.species + '\n' + 
                              "Naam: " + animal.name + '\n' +
                              "Leeftijd: " + animal.age + '\n' + 
                              "Chipnummer: " + animal.regnr + '\n' +
                              "Gereserveerd: " + animal.reserved + '\n' + '\n' + "... is succesvol toegevoegd!");
                        
                        var cat_list = JSON.parse(localStorage.getItem('cats'));
                        if (!Array.isArray(cat_list)) {
                            cat_list = [];
                        }
                        cat_list.push(animal);
                        localStorage.setItem('cats', JSON.stringify(cat_list)); 
                                    }
                                else
                                {
                                    alert("Kies: True / False");
                                    event.preventDefault();
                                }
                            }
                        else
                        {
                            alert("Vul een chipnummer tussen de 0 en de 100000 in");
                            event.preventDefault();
                        }
                    }
                    else
                    {
                        alert("Vul de leeftijd in, groter dan 0 of laat het veld leeg");
                        event.preventDefault();
                    }
            }
            else
            {
                alert("Vul een naam in");
                event.preventDefault();
            }
        }  
};
$('#btn_submit').click(OnSubmit);