var api = "http://localhost:3000/courses";

function start(){
    getCourse(innerHTML);
    handleCreate();
}

start();

function getCourse(callback){
    fetch(api)
        .then(function(respone){
            return respone.json();
        })
        .then(callback)
}

function createCourse(data, callback){
    console.log(data);
    var option = {
        method: 'POST',
        body : JSON.stringify(data)
    };
    fetch(api, option)
        .then(function(respone){
            respone.json();
        })
        .then(callback)
}

function deleteCourse(id){
    var option = {
        method: 'DELETE',
    };
    fetch(api + '/' + id, option)
        .then(function(respone){
            respone.json();
        })
        .then(function (){})
}

function innerHTML(courses){
    var listCourse = document.querySelector("#list-courses");
    var html = courses.map(function(course){
        return`
            <li data-id="${course.id}">
                <h4>${course.title}</h4>
                <p>${course.desc}</p>
                <button onclick="deleteCourse('${course.id}')">Xoá</button>
            </li> 
        `;
    });
    listCourse.innerHTML = html.join('');
}

function handleCreate(){
    var createBtn = document.querySelector('#create');
    createBtn.onclick = function(){
        var title = document.querySelector('input[name="title"]').value;
        var desc = document.querySelector('input[name="desc"]').value;
        var data = {
            title : title,
            desc : desc 
        }
        createCourse(data);
    }
}