function SubmitLogin(login, password){
    let url = `http://localhost:8888/users/${login}/${password}`;

    $.ajax({
        contentType: "application/json",
        type: "GET",
        url: url,
        data: "",
        success: function(data)
        {
            try{
                localStorage.setItem('userSession', JSON.stringify(data));
                window.location.href = "index.html";
            }catch(err) {
                alert("Błąd logwania");
            }
        },
        error: function(err){
            HandleError(err);
        }
    });
}

function HandleError(error){
    let errorMessage = error.responseJSON.ResponseStatus.Message;
    alert(errorMessage);
}

function SubmitRegister(userName, password, fullUserName){
    let url = `http://localhost:8888/users/addnew`;

    $.ajax({
        contentType: "application/json",
        type: "POST",
        url: url,
        data: JSON.stringify({
            UserName: userName,
            Password: password,
            FullUserName: fullUserName
        }),
        success: function()
        {
                window.location.href = "succregister.html";
        },
        error: function(err){
            HandleError(err);
        }
    });
}

function SubmitComment(exerciseLevel, exerciseNumber, commentText){
    let url = `http://localhost:8888/comments/addnew`;

    let userSession = JSON.parse(localStorage.getItem('userSession'));

    $.ajax({
        contentType: "application/json",
        type: "POST",
        url: url,
        data: JSON.stringify({
            UserId: userSession.Id,
            ExerciseLevel: exerciseLevel,
            ExerciseNumber: exerciseNumber,
            CommentText: commentText
        }),
        success: function()
        {
            alert("Komentarz został dodany");
        },
        error: function(err){
            HandleError(err);
        }
    });
}

function cleanUp(){
    localStorage.removeItem('userSession');
    alert("Wylogowano!");
}

function GetCommentsForGame(exerciseLevel, exerciseNumber){
    let url = `http://localhost:8888/comments/${exerciseLevel}/${exerciseNumber}`;

    $.ajax({
        contentType: "application/json",
        type: "GET",
        url: url,
        data: '',
        success: function(data)
        {
            return data;
        },
        error: function(err){
            HandleError(err);
        }
    });
}