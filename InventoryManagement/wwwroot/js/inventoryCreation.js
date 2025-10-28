let fieldCount = 1;        // we already have Field 1 (index 0)
let wizardStep = 1;
const totalSteps = document.querySelectorAll("[id^='table-creation-step-']").length;
const container = document.getElementById("table-fields");
const addFieldBtn = document.getElementById("add-field");
const removeFieldBtn = document.getElementById("remove-field");
const previousBtn = document.getElementById("previous-btn");
const nextBtn = document.getElementById("next-btn");
const submitBtn = document.getElementById("create-inventory");

addFieldBtn.addEventListener("click", (e) => {
    e.preventDefault();
    fieldCount++;

    const index = fieldCount - 1; // 2nd row => index 1
    const row = document.createElement("div");
    row.className = "mb-3 d-flex align-items-center gap-3 field-row";
    row.id = `field-${fieldCount}`;
    row.dataset.index = index;

    row.innerHTML = `
    <label for="field-name-${fieldCount}" class="form-label mb-0">Field ${fieldCount}</label>
    <input type="text"
           class="form-control w-auto"
           id="field-name-${fieldCount}"
           name="Fields[${index}].Name"
           placeholder="Name">
    <select class="form-select w-auto"
            id="field-type-${fieldCount}"
            name="Fields[${index}].Type">
      <option value="" selected disabled>Type</option>
      <option value="string">String</option>
      <option value="integer">Integer</option>
      <option value="boolean">Boolean</option>
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
