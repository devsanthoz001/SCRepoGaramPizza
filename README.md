# SCRepoGaramPizza
Implementing step one, registration page


razor file:

@page "/registration"
<div style="background-color: yellowgreen;">
    <h2 style="background-color: yellow; color:red">
        GARAM
        <small class="text-body-secondary" style="background-color: red; color:white">PIZZA</small>
    </h2>

    <br>
    <br>

    <div class="container" style="background-color: yellowgreen;">
        <div class="input-group mb-3">
            <span class="input-group-text" id="basic-addon1">Name :</span>
            <input type="text" class="form-control" placeholder="Username" aria-label="Username"
                aria-describedby="basic-addon1">
        </div>
        <br>

        <div class="input-group mb-3">
            <span class="input-group-text" id="basic-addon1">Mobile Number :</span>
            <input type="number" class="form-control" placeholder="Enter Mobile Number">
        </div>

        <br>

        <div class="input-group">
            <span class="input-group-text">Address :</span>
            <textarea class="form-control" aria-label="With textarea"></textarea>
        </div>

        <br>

        <button type="button" class="btn btn-success" @onclick="AddToRecord"> Register </button>
    </div>

</div>
