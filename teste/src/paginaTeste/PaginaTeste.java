package paginaTeste;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class PaginaTeste
 */
@WebServlet("/PaginaTeste")
public class PaginaTeste extends HttpServlet {
	private static final long serialVersionUID = 1L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
				//.append("Served at: ").append(request.getContextPath());

		out.printf("%s%s%s", "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>");

		out.println("<html>");

		out.println("<head>");

		out.println("<title>Teste site</title>");

		out.println("</head>");

		out.println("<body>");

		out.println("<h1>Texto em evidencia</h1>");

		out.println("<p>Parágrafo com texto, texto, texto, texto, texto, texto, texto, texto....</p>");

		out.println("</body>");

		out.println("</html>");
		out.close();
	}


	//protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		////doGet(request, response);
	//}

}
