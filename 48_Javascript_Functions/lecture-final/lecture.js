function concatAll(){
  let result='';
  for (let index = 0; index < arguments.length; index++) {
    result += arguments[index];
    
  }
  return result;
}

let bar = 0;
function noReturn(foo)
{
  bar = foo;
}

function returnBar()
{
  console.log(bar);
}

let numbers = [1,2,3,4];
let evenNumbers = numbers.filter((passedInNumber) => {
  return passedInNumber % 2 === 0;
})
console.log(evenNumbers);

let words = ["Always","Anywhere","Basically","Bravo","Valve"];
let outWords = words.filter((wordIn) => {
  let aAtStart = wordIn.startsWith("A");
  let eAtEnd = wordIn.endsWith("e");
  return aAtStart || eAtEnd;
})

console.log(outWords);

// Foreeach
words.forEach((item) => {
  if(item.endsWith("e")){
    console.log(item);
  }
})

// Map
let baseNumbers = [1,2,3,4,5,6,7,8,9];
let squares = baseNumbers.map((nums) => {
  return nums * nums;
})

console.table(squares);

// Reducer
let nameParts = ["henry","edwards"];
let fullName = nameParts.reduce((workingString,item) => {
  return workingString + ' ' + item.substring(0,1).toUpperCase() + item.substring(1);
},'');
console.log("Hello " + fullName);

function addContact(id,callBack)
{
  console.log("The id is " + id);
  callBack();
}

function refreshList(){
  //alert("In refreshList. Hello!");
}

addContact(42,refreshList);


/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

/**
 * Write a function called multiplyTogether that multiplies two numbers together. But 
 * what happens if we don't pass a value in? What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */

/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 */
function multiplyTogetherBase(firstParameter,secondParameter)
{
  return firstParameter * secondParameter;
}

function multiplyTogether(firstParameter = 0, secondParameter = 0)
{
  return firstParameter * secondParameter;
}
// Just using a base function
function multiplyTogether(firstParameter = 0, secondParameter = 0)
{
  return multiplyTogetherBase(firstParameter,secondParameter);
}

function multiplyNoUndefined(firstParameter = 0, secondParameter = 0)
{
  return firstParameter * secondParameter;
}
/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  return numbersToSum.reduce((sum,number) => {
    return sum += number;
  },0);
}

/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) {
  return numbersToFilter.filter((number) => {
    return number % 3 === 0;
  })
}
