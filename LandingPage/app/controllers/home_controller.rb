class HomeController < ApplicationController
	def index 
		@projects = Project.all
	end

	before_action :authenticate_user!
end
