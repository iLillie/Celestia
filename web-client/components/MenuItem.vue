<template>
  <li class="font-medium text-lg text-gray-600">
    <a :class="linkClass"
       class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out hover:bg-gray-200" :href="linkItem.href">
      <span :class="linkItem.icon"></span>
      <div :class="textClass" class="">
        <p>{{ linkItem.text }}</p>
      </div>
    </a>
  </li>
</template>

<script>
export default {
  props: {
    linkItem: Object
  },
  computed: {
    linkClass() {
      let isActive = this.$route.path == this.linkItem.href;
      let isCollapsed = this.$parent.isCollapsed;
      return {
        'bg-gray-100 text-black': isActive,
        'justify-center': isCollapsed,
      }
    },
    textClass() {
      let isCollapsed = this.$parent.isCollapsed;
      return {
        'hidden': isCollapsed,
      }
    }
  },

}
</script>
