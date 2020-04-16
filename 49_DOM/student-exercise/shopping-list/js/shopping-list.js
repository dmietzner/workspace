// add pageTitle
const name = 'My Shopping List';

// add groceries
const groceries = [
{item:'Bananas'},
{item:'Cookies'},
{item:'Milk'},
{item:'Ice cream'},
{item:'Potatoes'},
{item:'Celery'},
{item:'Butter'},
{item:'Bread'},
{item:'Beef'},
{item:'Chicken'}
]
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
const pageTitle = document.querySelector('#title').innerText = name;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
const list = document.querySelector('.shopping-list');
groceries.forEach((groceryItem) => {
const container = document.createElement('li');
container.classList.add('item');
container.innerText = groceryItem.item;
list.insertAdjacentElement("beforeend",container);
})
}
/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  var complete = document.getElementsByClassName("item");
  for (var i=0; i< complete.length; i++){
    complete[i].classList.add('completed');
  }
}





setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
