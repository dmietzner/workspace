const appURL = "https://localhost:44311/api/";
const appimageUrl = "img/";
let parks = [];

document.addEventListener('DOMContentLoaded',() => {
    // let's load the main parks
    fetch(appURL + 'parks')
    .then(response => response.json())
    .then(data => {
        parks = data;
        displayParks();
    })

})

function displayParks(){
    // get the template, loop through the parks. 
    if('content' in document.createElement('template')) {
        // query the document for .reviews and assign it to a variable called container
        const container = document.querySelector("#parkList");
        const tmpl = document.querySelector("#parkListing_template");
        container.innerText = '';
        // loop over the reviews array
        parks.forEach((park) => {
          // get the template; find all the elements and add the data from our review to each element
          const parkTemplate = tmpl.content.cloneNode(true);
          parkTemplate.querySelector('img').setAttribute("src", appimageUrl + "parks/" + park.parkCode.toLowerCase() + ".jpg");
          parkTemplate.querySelector('h2').innerText = park.parkName;
          parkTemplate.querySelector('#parkDescription').innerText = park.description;
          // add the event listener
          parkTemplate.querySelector('a').addEventListener('click',(event) => {
              event.preventDefault();
              DisplayDetail(park.parkCode);
          })
          container.appendChild(parkTemplate);
        });
      } else {
        console.error('Your browser does not support templates');
      }
}

function DisplayDetail(parkCode)
{
    const park = parks.filter(x => x.parkCode === parkCode)[0];
    const container = document.querySelector("#parkList");
    container.innerText = '';
    const detail = document
        .getElementById('park-detail')
        .content
        .cloneNode(true);

    const imageUrl = appimageUrl + "parks/"
    detail.getElementById('parkDetailImage').src  = imageUrl + park.parkCode.toLowerCase() + ".jpg";
    detail.querySelector('h1').innerText = park.parkName;

    const parkStats = detail.querySelectorAll('#parkStats label');
    for (let index = 0; index < parkStats.length; index++) {
        let textValue = '';
        let labelValue = '';
        switch (index) {
            case 0:
                textValue = park.state;
                labelValue ="State:";
                break;
            case 1:
                textValue = park.acreage;
                labelValue = "Acreage:";
                break;
            case 2:
                textValue = park.elevationInFeet;
                labelValue = "Elevation In Feet:";
                break;   
            case 3:
                textValue = park.milesOfTrail;
                labelValue = "Miles Of Trail:";
                break;
            case 4:
                textValue = park.numberOfCampsites;
                labelValue = "Number Of Campsites:";
                break;                
            case 5:
                textValue = park.climate;
                labelValue = "Climate:";
                break;
            case 6:
                textValue = park.yearFounded;
                labelValue = "Year Founded:";
                break;
            case 7:
                textValue = park.annualVisitorCount;
                labelValue = "Annual Visitor Count:";
                break;
            case 8:
                textValue = park.entryFee;
                labelValue = "Entry Fee:";
                break;
            case 9:
                textValue = park.numberOfAnimalSpecies;
                labelValue = "Number Of Animal Species:";
                break;
            default:
                break;
        }
        parkStats[index].innerText = labelValue;
        const stateText = document.createElement("span");
        stateText.innerText = " " + textValue;
        parkStats[index].insertAdjacentElement('afterEnd',stateText);
    }
    // process the quote
    const quoteDiv = detail.getElementById('quote');
    const quoteText = document.createElement("span");
    quoteText.innerText = park.inspirationalQuote;
    quoteDiv.querySelector('strong').insertAdjacentElement('afterBegin',quoteText);
    quoteDiv.querySelector('em').innerText = " - " + park.inspirationalQuoteSource;
    // display the description
    detail.getElementById('parkDetailDescription').innerText = park.description;
    // process the weather
    const todayWeather = park.weather.find((item) => {
        return item.fiveDayForecastValue == 1;
    })
    const weatherDiv = detail.getElementById('weatherDiv');
    const weatherTemplate = document.querySelector("#weatherTemplate");
    let weatherBlock = weatherTemplate.content.cloneNode(true);
    weatherDiv.appendChild(populateWeather(weatherBlock,todayWeather,true));

    const restOfWeather = park.weather.filter((item) => {
        return item.fiveDayForecastValue != 1;
    })

    restOfWeather.forEach((item) => {
        weatherBlock = weatherTemplate.content.cloneNode(true);
        weatherDiv.appendChild(populateWeather(weatherBlock,item,false));
    })

     container.appendChild(detail);
}

function populateWeather(element,weather,first)
{
    if(first)
    {
        element.querySelector('img').classList.add('todayImage');
    } else 
    {
        element.querySelector('img').classList.add('otherImage');
    }
    element.querySelector('img').src = appimageUrl + "weather/" + weather.forecast.replace(" ","") + ".png";
    element.querySelector('#highTemp').innerText = weather.highTemp + " " + weather.temperaturePreference;
    element.querySelector('#lowTemp').innerText = weather.lowTemp + " " + weather.temperaturePreference;
    element.querySelector('#recommendation').innerText = weather.recommendation;
    return element;
}

function ChangeTemperature(parkCode)
{
    fetch(appURL + 'parks/' + parkCode + '/weather/temp')
    .then(response => response.json())
    .then(data => {
        parks = data;
        DisplayDetail(parkCode);
    })
    
}