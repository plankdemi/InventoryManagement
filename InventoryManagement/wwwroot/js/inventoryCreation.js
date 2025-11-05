let fieldCount = 1;        // we already have Field 1 (index 0)
let wizardStep = 1;
const totalSteps = document.querySelectorAll("[id^='table-creation-step-']").length;
const container = document.getElementById("table-fields");
const addFieldBtn = document.getElementById("add-field");
const removeFieldBtn = document.getElementById("remove-field");
const previousBtn = document.getElementById("previous-btn");
const nextBtn = document.getElementById("next-btn");
const submitBtn = document.getElementById("create-inventory");
const myForm = document.getElementById("inventoryForm");


const tableNameInput = document.getElementById("table-name");


tableNameInput.addEventListener("input", function (e) {
    
    if(tableNameInput.value === "") {
        nextBtn.disabled = true;
    }else{
        nextBtn.disabled = false;
    }
})



addFieldBtn.addEventListener("click", (e) => {
    e.preventDefault();
    fieldCount++;

    const index = fieldCount - 1; 
    const row = document.createElement("div");
    row.className = "mb-3 d-flex align-items-center gap-3 field-row";
    row.id = `field-${fieldCount}`;
    row.dataset.index = index;

    row.innerHTML = `
    <label for="field-name-${fieldCount}" class="form-label mb-0">Field ${fieldCount}</label>
    <input type="text"
           class="form-control w-auto"
           id="field-name-${fieldCount}"
           name=""
           placeholder="Name">
                <select class="form-select w-auto">
                    <option value="type" selected disabled>Type</option>
                    <option value="string-single">Single Line</option>
                    <option value="string-multi">Multi Line</option>
                    <option value="numeric">Numeric</option>
                    <option value="boolean">Checkbox</option>
                    <option value="link">Document/Image (Entered As A Link)</option>
                </select>
  `;
    container.appendChild(row);
    updateFieldButtons();
});

removeFieldBtn.addEventListener("click", (e) => {
    e.preventDefault();
    if (fieldCount <= 1) return;
    container.lastElementChild.remove();
    fieldCount = container.children.length;
    updateFieldButtons();
});

function updateFieldButtons() {
    removeFieldBtn.classList.toggle("disabled", fieldCount === 1);
}

nextBtn.addEventListener("click", e => {
    e.preventDefault();
    wizardStep++;
    showStep(wizardStep);
    updateButtons();
});

previousBtn.addEventListener("click", e => {
    e.preventDefault();
    wizardStep--;
    showStep(wizardStep);
    updateButtons();
});

function showStep(step) {
    document.querySelectorAll("[id^='table-creation-step-']").forEach(el => el.classList.add("d-none"));
    document.getElementById(`table-creation-step-${step}`).classList.remove("d-none");
}

function updateButtons() {
    previousBtn.classList.toggle("d-none", wizardStep === 1);
    nextBtn.classList.toggle("d-none", wizardStep === totalSteps);
    submitBtn.classList.toggle("d-none", wizardStep !== totalSteps);
}

let singleLineIterator = 0;
let multiLineIterator = 0;
let numericIterator = 0;
let checkboxIterator = 0;
let docimageIterator = 0;
let index = 1;
myForm.addEventListener("submit", (e) => {
    
    const myFields = document.querySelectorAll(".form-select");
    for (const field of myFields) {
        switch(field.value){
            case "string-single":
                singleLineIterator++;
                document.getElementById(`field-name-${index}`).name = `CustomSingleStringName${singleLineIterator}`
                break;
            case "string-multi":
                multiLineIterator++;
                document.getElementById(`field-name-${index}`).name = `CustomMultiStringName${multiLineIterator}`
                break;
            case "numeric":
                numericIterator++;
                document.getElementById(`field-name-${index}`).name = `CustomIntName${numericIterator}`
                break;
            case "boolean":
                checkboxIterator++;
                document.getElementById(`field-name-${index}`).name = `CustomBoolName${checkboxIterator}`
                break;
            case "link":
                docimageIterator++;
                document.getElementById(`field-name-${index}`).name = `CustomLinkName${docimageIterator}`
                break;
        }
        index++;
        
        
    }

    const ok =
        singleLineIterator <= 3 &&
        multiLineIterator  <= 3 &&
        numericIterator    <= 3 &&
        checkboxIterator   <= 3 &&
        docimageIterator   <= 3;

    if (!ok) {
        e.preventDefault();
        return;
    }


});

myForm.addEventListener("formdata", (e) => {
   
    for (let i = 1; i <= singleLineIterator; i++) {
        e.formData.append(`CustomSingleStringState${i}`, "true");
    }
    
    for (let i = 1; i <= multiLineIterator; i++) {
        e.formData.append(`CustomMultiStringState${i}`, "true");
    }
    for (let i = 1; i <= numericIterator; i++) {
        e.formData.append(`CustomIntState${i}`, "true");
    }
    for (let i = 1; i <= checkboxIterator; i++) {
        e.formData.append(`CustomBoolState${i}`, "true");
    }
    for (let i = 1; i <= docimageIterator; i++) {
        e.formData.append(`CustomLinkState${i}`, "true");
    }
});

