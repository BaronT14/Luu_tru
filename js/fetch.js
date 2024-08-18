
var api = 'http://localhost:3000/courses';

function start(){
    getCourse(renderCode);
}

start();

function getCourse(callback){
    fetch(api)
        .then(function(respone){
            return respone.json();
        })
        .then(callback)
}

function renderCode(courses){
    var listCourses = document.querySelector('#list-courses');
    var html = courses.map(function(course){
        return `
            <li>
                <h4>${course.title}</h4>
                <p>${course.des}</p>
            </li>
        `;
    });
    console.log(html.join(''));
    listCourses.innerHTML = html.join('');
}