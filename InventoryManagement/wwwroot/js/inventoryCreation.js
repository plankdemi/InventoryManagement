let fieldCount= 1;
let wizardStep = 1;
const totalSteps = document.querySelectorAll("[id^='table-creation-step-']").length;
const container = document.getElementById("table-fields");
const addFieldBtn = document.getElementById("add-field");
const removeFieldBtn = document.getElementById("remove-field");
const previousBtn = document.getElementById("previous-btn");
const nextBtn = document.getElementById("next-btn");
const submitBtn = document.getElementById("create-inventory");

addFieldBtn.addEventListener("click", (e) =>{
    e.preventDefault();
    fieldCount++;
    const field = document.createElement("div");
    field.className = "mb-3 d-flex align-items-center gap-3";
    field.id = `field-${fieldCount}`;
    
    field.innerHTML = `
        <label for="field-name-${fieldCount}" class="form-label mb-0">Field ${fieldCount}</label>
            <input type="text" class="form-control w-auto" id="field-name-${fieldCount}" placeholder="Name">
            <select class="form-select w-auto" id="field-type-${fieldCount}">
                <option selected disabled>Type</option>
                <option value="string">String</option>
                <option value="integer">Integer</option>
                <option value="boolean">Boolean</option>
            </select>
`;
    container.appendChild(field);
    updateFieldButtons();
    
});

removeFieldBtn.addEventListener("click", (e) =>{
    e.preventDefault();
  container.lastElementChild.remove();
  fieldCount = container.children.length;
    updateFieldButtons();

})

function updateFieldButtons(){
    removeFieldBtn.classList.toggle("disabled",fieldCount === 1);
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