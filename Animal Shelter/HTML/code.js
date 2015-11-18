function OnReady() {
  console.log('Pagina geladen, DOM klaar voor gebruik.');
    $('p').addClass('hidden');
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