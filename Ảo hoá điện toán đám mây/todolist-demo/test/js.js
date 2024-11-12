// JavaScript for Todo List functionality
document.getElementById('add-btn').addEventListener('click', function() {
    const todoText = document.getElementById('new-todo').value;
    
    if (todoText.trim() !== '') {
        addTodoItem(todoText);
        document.getElementById('new-todo').value = ''; // Clear input after adding
    }
});

function addTodoItem(text) {
    const todoList = document.getElementById('todo-list');

    // Create list item
    const listItem = document.createElement('li');
    listItem.classList.add('todo-item');

    // Create todo text
    const todoText = document.createElement('span');
    todoText.textContent = text;

    // Create buttons container
    const buttonsDiv = document.createElement('div');
    buttonsDiv.classList.add('todo-buttons');

    // Complete button
    const completeBtn = document.createElement('button');
    completeBtn.classList.add('complete-btn');
    completeBtn.innerHTML = '✔️';
    completeBtn.addEventListener('click', function() {
        listItem.classList.toggle('completed');
    });

    // Delete button
    const deleteBtn = document.createElement('button');
    deleteBtn.classList.add('delete-btn');
    deleteBtn.innerHTML = '❌';
    deleteBtn.addEventListener('click', function() {
        todoList.removeChild(listItem);
    });

    // Append buttons to the buttons container
    buttonsDiv.appendChild(completeBtn);
    buttonsDiv.appendChild(deleteBtn);

    // Append text and buttons to the list item
    listItem.appendChild(todoText);
    listItem.appendChild(buttonsDiv);

    // Append list item to the todo list
    todoList.appendChild(listItem);
}
