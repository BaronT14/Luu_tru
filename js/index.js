// var watchList = [
//     {
//       "Title": "Inception",
//       "Year": "2010",
//       "Rated": "PG-13",
//       "Released": "16 Jul 2010",
//       "Runtime": "148 min",
//       "Genre": "Action, Adventure, Crime",
//       "Director": "Christopher Nolan",
//       "Writer": "Christopher Nolan",
//       "Actors": "Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page, Tom Hardy",
//       "Plot": "A thief, who steals corporate secrets through use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.",
//       "Language": "English, Japanese, French",
//       "Country": "USA, UK",
//       "imdbRating": "8.8",
//       "imdbVotes": "1,446,708",
//       "imdbID": "tt1375666",
//       "Type": "movie",
//     },
//     {
//       "Title": "Interstellar",
//       "Year": "2014",
//       "Rated": "PG-13",
//       "Released": "07 Nov 2014",
//       "Runtime": "169 min",
//       "Genre": "Adventure, Drama, Sci-Fi",
//       "Director": "Christopher Nolan",
//       "Writer": "Jonathan Nolan, Christopher Nolan",
//       "Actors": "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow",
//       "Plot": "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
//       "Language": "English",
//       "Country": "USA, UK",
//       "imdbRating": "8.6",
//       "imdbVotes": "910,366",
//       "imdbID": "tt0816692",
//       "Type": "movie",
//     },
//     {
//       "Title": "The Dark Knight",
//       "Year": "2008",
//       "Rated": "PG-13",
//       "Released": "18 Jul 2008",
//       "Runtime": "152 min",
//       "Genre": "Action, Adventure, Crime",
//       "Director": "Christopher Nolan",
//       "Writer": "Jonathan Nolan (screenplay), Christopher Nolan (screenplay), Christopher Nolan (story), David S. Goyer (story), Bob Kane (characters)",
//       "Actors": "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
//       "Plot": "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.",
//       "Language": "English, Mandarin",
//       "Country": "USA, UK",
//       "imdbRating": "9.0",
//       "imdbVotes": "1,652,832",
//       "imdbID": "tt0468569",
//       "Type": "movie",
//     },
//     {
//       "Title": "Batman Begins",
//       "Year": "2005",
//       "Rated": "PG-13",
//       "Released": "15 Jun 2005",
//       "Runtime": "140 min",
//       "Genre": "Action, Adventure",
//       "Director": "Christopher Nolan",
//       "Writer": "Bob Kane (characters), David S. Goyer (story), Christopher Nolan (screenplay), David S. Goyer (screenplay)",
//       "Actors": "Christian Bale, Michael Caine, Liam Neeson, Katie Holmes",
//       "Plot": "After training with his mentor, Batman begins his fight to free crime-ridden Gotham City from the corruption that Scarecrow and the League of Shadows have cast upon it.",
//       "Language": "English, Urdu, Mandarin",
//       "Country": "USA, UK",
//       "imdbRating": "8.3",
//       "imdbVotes": "972,584",
//       "imdbID": "tt0372784",
//       "Type": "movie",
//     },
//     {
//       "Title": "Avatar",
//       "Year": "2009",
//       "Rated": "PG-13",
//       "Released": "18 Dec 2009",
//       "Runtime": "162 min",
//       "Genre": "Action, Adventure, Fantasy",
//       "Director": "James Cameron",
//       "Writer": "James Cameron",
//       "Actors": "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang",
//       "Plot": "A paraplegic marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
//       "Language": "English, Spanish",
//       "Country": "USA, UK",
//       "imdbRating": "7.9",
//       "imdbVotes": "876,575",
//       "imdbID": "tt0499549",
//       "Type": "movie",
//     }
//   ];
  
//   function calculateRating(watchList){
//     var newarr = watchList.filter(function(newarr, item){
//         return newarr.Director === 'Christopher Nolan';
//     });

//     var rate = newarr.reduce(function(imdb, item){
//         return imdb + parseFloat(item.imdbRating)
//     }, 0);

//     return rate / newarr.length;
//   };
  
//   // Expected results
//   console.log(calculateRating(watchList)); // Output: 8.675

// function arrToObj(arr){
//     var obj = arr.reduce(function(i, item){
//         i[item[0]] = item[1]
//         return i;
//     }, {})
//     return obj
// }
 
// // Expected results:
// var arr = [
//     ['name', 'Sơn Đặng'],
//     ['age', 18],
// ];
// console.log(arrToObj(arr)); // { name: 'Sơn Đặng', age: 18 }

// function sumCb(a, b) {
//     return a + b;
// }

//     return a - b;
// }

// function multiCb(a, b) {
//     return a * b;
// }

// function divCb(a, b) {
//     return a / b;
// }

// function caculate(a, b, cb) {
//     return cb(a, b);
// }

// // Expected results
// // caculate(1, 2, sumCb) // Output: 3
// // caculate(1, 2, subCb) // Output: -1
// // caculate(1, 2, multiCb) // Output: 2
// // caculate(3, 1, divCb) // Output: 3

// Array.prototype.myMap = function(cb) {
//     var len = this.length, arr = [];
//     for(let i in this){
//         arr.push(cb(this[i]));
//     }
//     return arr;
// }

// // Expected results
// const numbers = [1, 2, 3];

// console.log(numbers.myMap(function (number) {
//     return number * 2;
// })) // Output: [2, 4, 6]

// console.log(numbers.myMap(function (number, index) {
//     return number * index;
// })) // Output: [0, 2, 6]

// var courses = [
//     {
//         name : "Java",
//         coin : 500
//     },
//     {
//         name : "Php",
//         coin : 500
//     },     
//     {
//         name : "Ruby",
//         coin : 100
//     }
// ];

// // console.log(courses.filter(function(course){
// //     return course.coin > 400;
// // }));

// Array.prototype.filter2 = function(cb){
//     var results = []
//     for(var i in this){
//         var item = cb(this[i])
//         if(item)
//             results.push(this[i]);
//     }
//     return results;
// }

// console.log(courses.filter2(function(course){
//     return course.coin > 400;
// }));

// Array.prototype.myFilter = function(cb) {
//     var results = [];
//     for (var i in this){
//         if(this.hasOwnProperty(i)){
//             var item = cb(this[i], i, this);
//             if(item)
//                 results.push(this[i]);
//         }
//     }
//     return results;
// }



// // Expected results:

// const numbers = [1, 2, 3, 4];

// // console.log(numbers.myFilter(function (number) {
// //     return number % 2 === 0;
// // })); //Output: [2, 4]

// // console.log(numbers.myFilter(function (number, index) {
// //     return index % 2 === 0;
// // })); //Output: [1, 3]

// console.log(numbers.myFilter(function (number, index, array) {
//     return array.length % 2 === 0;
// })); //Output: [1, 2, 3, 4]

// Array.prototype.mySome = function(cb) {
//     for(var i in this){
//         if(this.hasOwnProperty(i)){
//             var temp = cb(this[i], i, this);
//             if (temp){
//                 return true;
//             }
//         }
//     }
//     return false;
// }



// //Expected results:

// const numbers = new Array(100);

// // console.log(numbers.mySome(function (number) {
// //     return number % 2 === 0;
// // })); //Output: false

// // console.log(numbers.mySome(function (number, index) {
// //     return index % 2 === 0;
// // })); //Output: true

// console.log(numbers.mySome(function (number, index, array) {
//     return array.length % 2 === 0;
// })); //Output: true


// Array.prototype.myEvery = function(cb) {
//     for(var i in this){
//         if(this.hasOwnProperty(i)){
//             var temp = cb(this[i], i, this);
//             if(temp === false)
//                 return false;
//         }
//     }
//     return true;
// }


// // Expected results

// const numbers = [1, 3, 3, 5];

// console.log(numbers.myEvery(function (number) {
//     return number % 2 !== 0;
// })); // Output: true

// console.log(numbers.myEvery(function (number, index) {
//     return index % 2 === 0;
// })); // Output: false

// console.log(numbers.myEvery(function (number, index, array) {
//     return array.length % 2 === 0;
// })); // Output: true


