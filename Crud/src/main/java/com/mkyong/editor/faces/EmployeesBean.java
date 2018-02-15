package com.mkyong.editor.faces;

import com.mkyong.editor.dao.EmployeeActions;
import com.mkyong.editor.dao.InDbEmployeeActions;
import com.mkyong.editor.domain.Employee;
import org.primefaces.context.RequestContext;
import org.primefaces.model.LazyDataModel;
import sun.security.validator.ValidatorException;

import javax.annotation.PostConstruct;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.component.UIComponent;
import javax.faces.context.FacesContext;
import java.io.Serializable;
import java.text.ParseException;
import java.util.Date;
import java.util.Locale;

@ManagedBean(name = "employees")
@SessionScoped
public class EmployeesBean implements Serializable {

    private long id;
    private String department;
    private String name;
    private String position;
    private Date date;
    private boolean save = false;
    private boolean add = false;
    private EmployeeActions employeeActions;
    private LazyDataModel<Employee> lazyModel;
    private String language;

    @PostConstruct
    public void init() {
        employeeActions = new InDbEmployeeActions();
        lazyModel = new LazyModelHolder(employeeActions);

    }

    private Locale locale = FacesContext.getCurrentInstance().getViewRoot().getLocale();

    public Locale getLocale() {
        return locale;
    }

    public String getLanguage() {
        return locale.getLanguage();
    }

    public void changeLanguage(String language) {
        this.language = language;
        locale = new Locale(language);
        FacesContext.getCurrentInstance().getViewRoot().setLocale(new Locale(language));
    }


    public LazyDataModel<Employee> getLazyModel() {

        return lazyModel;
    }

    public Date today() {
        Date today = new Date();

        return today;
    }

    public String changeTrueAddButton() {
        add = true;
        return null;
    }

    public String changeFalseSaveButton() {
        save = false;
        return null;
    }

    public void opendialog() {

        clear();

        changeTrueAddButton();
        changeFalseSaveButton();
        RequestContext.getCurrentInstance().
                addCallbackParam("notValid123", true);

    }


    public String changeTrueSaveButton() {
        save = true;
        return null;
    }

    public String changeFalseAddButton() {
        add = false;
        return null;
    }

    public String opendialogFromEdit() {
        changeFalseAddButton();
        changeTrueSaveButton();

        return null;
    }

    public String clear() {
        this.name = null;
        this.position = null;
        this.department = null;
        this.date = null;
        return null;
    }

    public String exitAndClear() {
        this.name = null;
        this.position = null;
        this.department = null;
        this.date = null;
        RequestContext.getCurrentInstance().
                addCallbackParam("notValid9", true);
        return null;
    }


    public void validate(FacesContext context, UIComponent component, Object value) throws ValidatorException {
        Date today = new Date();

        if ((((Date) value).after(today)) && language.equals("")) {
            context = FacesContext.getCurrentInstance();
            context.addMessage(component.getClientId(), new FacesMessage(FacesMessage.SEVERITY_ERROR, "Error!", "Date does not exists"));

        }else if (((((Date) value).after(today)) && language.equals("lt"))){
            context = FacesContext.getCurrentInstance();
            context.addMessage(component.getClientId(), new FacesMessage(FacesMessage.SEVERITY_ERROR, "Error!", "Jūsų pasirinkta data neegzistuoja"));
        }

    }

    public boolean addEmployee() throws ParseException {
        Date today = new Date();

        boolean success;

        int nameLength = this.name.length();
        int positionLength = this.position.length();
        int departmentLength = this.department.length();


        int dateLength = 4;
        if (this.date.before(today)) {
            String dateString = String.valueOf(this.date);
            dateLength = dateString.length();
        }
        if (departmentLength > 0 && nameLength > 0 && positionLength > 0 && dateLength > 4) {
            success = true;
            Employee employee = new Employee(this.name, this.position, this.department, this.date);
            employeeActions.addNewEmployee(employee);
//            getEmployeesList();
        } else {
            success = false;
        }

        RequestContext.getCurrentInstance().
                addCallbackParam("notValid", success);


        return true;
    }

    public String editEmployeeRecord(long employeeId) {

        opendialogFromEdit();
        Employee employee = employeeActions.editEmployeeRecords(employeeId);
        this.name = employee.getName();
        this.position = employee.getPosition();
        this.department = employee.getDepartment();
        this.id = employee.getId();
        this.date = employee.getDate();

        return null;
    }

    public String updateEmployeeDetails() {
        Date today = new Date();
        boolean success;
        int departmentLength = this.department.length();
        int nameLength = this.name.length();
        int positionLength = this.position.length();

        int dateLength = 4;
        if (this.date.before(today)) {
            String dateString = String.valueOf(this.date);
            dateLength = dateString.length();
        }

        if (departmentLength > 0 && nameLength > 0 && positionLength > 0 && dateLength > 4) {
            Employee employee = new Employee(this.name, this.position, this.department, this.id, this.date);
            employeeActions.updateEmployeeRecords(employee);
            success = true;
        } else {
            success = false;
        }
        RequestContext.getCurrentInstance().
                addCallbackParam("notValid", success);

        return null;
    }


    public void deleteEmployeeRecord(int employeeId) {

        employeeActions.deleteEmployeeRecords(employeeId);

    }

    //S and G
    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public String getDepartment() {

        return department;
    }

    public String getPosition() {
        return position;
    }

    public boolean isAdd() {
        return add;
    }

    public void setAdd(boolean add) {
        this.add = add;
    }

    public boolean isSave() {
        return save;
    }

    public void setSave(boolean save) {
        this.save = save;
    }


    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

}
