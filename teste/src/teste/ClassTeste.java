package teste;

import java.util.ArrayList;
import java.util.Collection;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;


@ManagedBean(name = "ClassTeste")
@SessionScoped
public class ClassTeste {
	
private Clientes clientePessoas;
private Collection<Clientes> lista;



public Clientes getClientePessoas() {
	return clientePessoas;
}
public void setClientePessoas(Clientes clientePessoas) {
	this.clientePessoas = clientePessoas;
}
public Collection<Clientes> getLista() {
	return lista;
}
public void setLista(Collection<Clientes> lista) {
	this.lista = lista;
}

public ClassTeste(){
	clientePessoas = new Clientes();
	lista = new ArrayList<Clientes>();
	
	for(int x = 0; x < 10; x++){
		Clientes c = new Clientes();
		c.setNome(String.format("fulano", x));
		c.setSobrenome(String.format("fulanodetal", x));
		c.setEmail(String.format("fulano@email.com", x));
		
		lista.add(c);
	}
  }

public void salvar(){
	if(!lista.contains(clientePessoas)){
		lista.add(clientePessoas);
		
	}
}
	
	
public void excluir(){
		
	lista.remove(clientePessoas);
	clientePessoas = new Clientes();
			
  }
     
}
    
